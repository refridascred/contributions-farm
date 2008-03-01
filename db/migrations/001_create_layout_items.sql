-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (level, ratio, token, score) VALUES (84, 63.82, 'eu-west', 16.77);
INSERT INTO layout_items (level, ratio, token, score) VALUES (27, 12.72, 'local', 77.91);
