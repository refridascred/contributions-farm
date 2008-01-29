-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (region, count, ratio, state, label) VALUES ('green', 19, 36.83, 'stable', 'blue');
INSERT INTO layout_items (region, count, ratio, state, label) VALUES ('local', 95, 24.44, 'fallback', 'green');
INSERT INTO layout_items (region, count, ratio, state, label) VALUES ('primary', 3, 0.11, 'strict', 'open');
