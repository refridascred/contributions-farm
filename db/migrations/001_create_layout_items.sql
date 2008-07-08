-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, token, level, score, ratio) VALUES (38, 'primary', 66, 7.46, 60.33);
INSERT INTO layout_items (count, token, level, score, ratio) VALUES (12, 'blue', 16, 15.91, 34.77);
