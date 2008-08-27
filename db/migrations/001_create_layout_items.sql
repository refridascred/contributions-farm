-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, count, rank, token) VALUES ('open', 81, 25, 'blue');
INSERT INTO layout_items (owner, count, rank, token) VALUES ('open', 26, 56, 'standard');
INSERT INTO layout_items (owner, count, rank, token) VALUES ('stable', 88, 41, 'standard');
