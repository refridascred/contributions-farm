-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (state, owner, rank, count) VALUES ('stable', 'blue', 42, 92);
INSERT INTO layout_items (state, owner, rank, count) VALUES ('latest', 'latest', 72, 48);
