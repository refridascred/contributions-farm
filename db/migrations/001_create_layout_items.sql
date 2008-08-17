-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, active, weight, token, ratio) VALUES (10, 68, 21.71, 'fallback', 4.05);
INSERT INTO layout_items (level, active, weight, token, ratio) VALUES (38, 89, 46.69, 'stable', 38.86);
INSERT INTO layout_items (level, active, weight, token, ratio) VALUES (51, 40, 59.59, 'latest', 91.94);
