-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (owner, active, rank, count, level) VALUES ('open', 9, 51, 81, 86);
INSERT INTO layout_items (owner, active, rank, count, level) VALUES ('edge', 8, 28, 75, 8);
INSERT INTO layout_items (owner, active, rank, count, level) VALUES ('staging', 2, 73, 48, 45);
