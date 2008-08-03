-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (label, score, weight, level, count) VALUES ('eu-west', 52.65, 5.94, 45, 53);
INSERT INTO layout_items (label, score, weight, level, count) VALUES ('fallback', 59.21, 66.15, 34, 53);
