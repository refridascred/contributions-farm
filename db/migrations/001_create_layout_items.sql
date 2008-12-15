-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    weight REAL,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (token, level, weight, ratio) VALUES ('staging', 81, 72.22, 4.8);
INSERT INTO layout_items (token, level, weight, ratio) VALUES ('stable', 4, 82.47, 19.22);
INSERT INTO layout_items (token, level, weight, ratio) VALUES ('green', 41, 77.87, 14.07);
