-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, score, owner) VALUES (97, 34.77, 'strict');
INSERT INTO layout_items (level, score, owner) VALUES (76, 98.64, 'primary');
INSERT INTO layout_items (level, score, owner) VALUES (10, 67.19, 'fallback');
