-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, state, region, label) VALUES (31.48, 'open', 'legacy', 'primary');
INSERT INTO layout_items (ratio, state, region, label) VALUES (23.58, 'green', 'local', 'edge');
