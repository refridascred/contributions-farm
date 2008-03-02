-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (rank, count, level, token) VALUES (90, 71, 42, 'primary');
INSERT INTO layout_items (rank, count, level, token) VALUES (74, 31, 81, 'local');
INSERT INTO layout_items (rank, count, level, token) VALUES (0, 73, 82, 'primary');
