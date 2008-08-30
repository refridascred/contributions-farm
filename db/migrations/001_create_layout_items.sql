-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (rank, state, level, owner) VALUES (84, 'latest', 36, 'local');
INSERT INTO layout_items (rank, state, level, owner) VALUES (7, 'eu-west', 69, 'cached');
