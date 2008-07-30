-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, weight, region, level) VALUES ('blue', 70.38, 'legacy', 39);
INSERT INTO layout_items (token, weight, region, level) VALUES ('cached', 27.57, 'open', 47);
