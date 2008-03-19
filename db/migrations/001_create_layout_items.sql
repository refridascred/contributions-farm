-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, owner, weight, rank, active) VALUES ('local', 'stable', 26.83, 98, 54);
