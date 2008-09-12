-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (state, active, label, ratio, region) VALUES ('blue', 22, 'local', 27.03, 'cached');
INSERT INTO layout_items (state, active, label, ratio, region) VALUES ('eu-west', 80, 'strict', 93.77, 'blue');
