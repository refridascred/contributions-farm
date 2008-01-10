-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    level INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, rank, level, weight, active) VALUES ('eu-west', 19, 50, 75.47, 11);
INSERT INTO layout_items (owner, rank, level, weight, active) VALUES ('edge', 48, 61, 9.99, 15);
