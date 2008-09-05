-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, region, label) VALUES (71.95, 'strict', 'eu-west');
INSERT INTO layout_items (weight, region, label) VALUES (34.18, 'fallback', 'cached');
INSERT INTO layout_items (weight, region, label) VALUES (77.65, 'stable', 'legacy');
