-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, label, region, level) VALUES (48.32, 'local', 'latest', 21);
INSERT INTO layout_items (weight, label, region, level) VALUES (43.11, 'staging', 'latest', 84);
INSERT INTO layout_items (weight, label, region, level) VALUES (28.35, 'strict', 'blue', 82);
