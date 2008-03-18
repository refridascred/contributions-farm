-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, token, ratio, score) VALUES (67, 'blue', 45.09, 42.61);
INSERT INTO layout_items (level, token, ratio, score) VALUES (35, 'cached', 26.52, 78.95);
