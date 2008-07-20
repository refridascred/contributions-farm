-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    weight REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (region, ratio, weight, token, count) VALUES ('edge', 33.42, 5.89, 'local', 63);
INSERT INTO layout_items (region, ratio, weight, token, count) VALUES ('eu-west', 75.52, 72.44, 'stable', 12);
INSERT INTO layout_items (region, ratio, weight, token, count) VALUES ('standard', 9.74, 3.76, 'staging', 45);
