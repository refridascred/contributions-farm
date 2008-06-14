-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (weight, token, region, count, level) VALUES (68.23, 'staging', 'open', 41, 70);
INSERT INTO layout_items (weight, token, region, count, level) VALUES (36.84, 'eu-west', 'eu-west', 1, 76);
