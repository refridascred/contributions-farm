-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, token, active, score) VALUES (11, 'stable', 12, 18.17);
INSERT INTO layout_items (level, token, active, score) VALUES (76, 'latest', 51, 50.66);
INSERT INTO layout_items (level, token, active, score) VALUES (60, 'edge', 0, 98.49);
