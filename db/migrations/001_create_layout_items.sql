-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (count, rank, label, level, token) VALUES (88, 13, 'strict', 31, 'eu-west');
INSERT INTO layout_items (count, rank, label, level, token) VALUES (91, 1, 'legacy', 85, 'fallback');
INSERT INTO layout_items (count, rank, label, level, token) VALUES (65, 12, 'eu-west', 19, 'fallback');
