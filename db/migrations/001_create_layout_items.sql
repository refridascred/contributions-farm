-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (level, score, ratio) VALUES (39, 55.72, 73.15);
INSERT INTO layout_items (level, score, ratio) VALUES (43, 12.26, 85.17);
INSERT INTO layout_items (level, score, ratio) VALUES (1, 70.0, 50.8);
