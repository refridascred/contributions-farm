-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, ratio, weight, active, label) VALUES ('fallback', 30.31, 4.73, 5, 'cached');
INSERT INTO layout_items (state, ratio, weight, active, label) VALUES ('staging', 19.82, 64.28, 36, 'staging');
