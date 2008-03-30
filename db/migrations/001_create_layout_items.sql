-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, region, weight, count) VALUES (73, 'eu-west', 26.76, 24);
INSERT INTO layout_items (level, region, weight, count) VALUES (27, 'primary', 64.52, 0);
INSERT INTO layout_items (level, region, weight, count) VALUES (64, 'primary', 61.27, 59);
