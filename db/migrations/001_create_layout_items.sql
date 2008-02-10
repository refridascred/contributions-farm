-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, region, label) VALUES (78.12, 'cached', 'blue');
INSERT INTO layout_items (ratio, region, label) VALUES (93.03, 'primary', 'local');
INSERT INTO layout_items (ratio, region, label) VALUES (57.58, 'edge', 'standard');
