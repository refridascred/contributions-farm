-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, score, label, ratio) VALUES (54, 14.32, 'staging', 77.33);
INSERT INTO layout_items (count, score, label, ratio) VALUES (23, 61.96, 'blue', 13.72);
INSERT INTO layout_items (count, score, label, ratio) VALUES (61, 77.91, 'latest', 38.85);
