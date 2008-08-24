-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (level, score, token, active) VALUES (5, 86.41, 'latest', 47);
INSERT INTO layout_items (level, score, token, active) VALUES (50, 35.9, 'strict', 52);
INSERT INTO layout_items (level, score, token, active) VALUES (41, 5.66, 'stable', 99);
