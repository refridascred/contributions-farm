-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, label, region) VALUES (16.82, 'edge', 'local');
INSERT INTO layout_items (weight, label, region) VALUES (96.54, 'green', 'stable');
INSERT INTO layout_items (weight, label, region) VALUES (57.6, 'latest', 'standard');
