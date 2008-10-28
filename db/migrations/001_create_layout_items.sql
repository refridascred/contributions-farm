-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, weight, token, region) VALUES ('strict', 30.05, 'cached', 'blue');
INSERT INTO layout_items (label, weight, token, region) VALUES ('eu-west', 37.39, 'open', 'edge');
