-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, token, count, level) VALUES (30, 'eu-west', 59, 69);
INSERT INTO layout_items (rank, token, count, level) VALUES (97, 'edge', 47, 54);
INSERT INTO layout_items (rank, token, count, level) VALUES (72, 'latest', 68, 3);
