-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, count, level, label, score) VALUES (86.18, 70, 22, 'green', 53.68);
INSERT INTO layout_items (ratio, count, level, label, score) VALUES (54.36, 15, 36, 'local', 94.37);
