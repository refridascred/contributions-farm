-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, score) VALUES (44, 38.59);
INSERT INTO layout_items (level, score) VALUES (90, 48.14);
INSERT INTO layout_items (level, score) VALUES (39, 89.41);
