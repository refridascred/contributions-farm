-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (state, count, level, rank, token) VALUES ('strict', 74, 28, 96, 'strict');
INSERT INTO layout_items (state, count, level, rank, token) VALUES ('strict', 39, 96, 37, 'blue');
INSERT INTO layout_items (state, count, level, rank, token) VALUES ('latest', 39, 65, 59, 'green');
