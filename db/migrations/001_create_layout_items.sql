-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    token TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, level, token, region, ratio) VALUES (41.39, 43, 'eu-west', 'open', 56.64);
INSERT INTO layout_items (weight, level, token, region, ratio) VALUES (88.89, 69, 'green', 'primary', 51.47);
INSERT INTO layout_items (weight, level, token, region, ratio) VALUES (7.64, 95, 'eu-west', 'local', 26.81);
