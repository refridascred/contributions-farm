-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, state, rank, score, owner) VALUES (76, 'eu-west', 44, 25.33, 'local');
INSERT INTO layout_items (active, state, rank, score, owner) VALUES (39, 'blue', 26, 30.07, 'green');
INSERT INTO layout_items (active, state, rank, score, owner) VALUES (87, 'eu-west', 86, 43.8, 'green');
