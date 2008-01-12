-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, region, weight) VALUES ('legacy', 'eu-west', 3.25);
INSERT INTO layout_items (token, region, weight) VALUES ('blue', 'legacy', 14.92);
INSERT INTO layout_items (token, region, weight) VALUES ('primary', 'green', 75.38);
