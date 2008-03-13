-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, score) VALUES (71, 7.96);
INSERT INTO layout_items (level, score) VALUES (13, 26.14);
INSERT INTO layout_items (level, score) VALUES (82, 53.39);
