-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, token, region, weight, rank) VALUES ('stable', 'strict', 'primary', 36.21, 32);
INSERT INTO layout_items (label, token, region, weight, rank) VALUES ('primary', 'open', 'primary', 53.47, 33);
INSERT INTO layout_items (label, token, region, weight, rank) VALUES ('fallback', 'open', 'eu-west', 53.91, 19);
