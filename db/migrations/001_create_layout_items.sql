-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (owner, active, ratio, rank, level) VALUES ('open', 85, 2.15, 76, 47);
INSERT INTO layout_items (owner, active, ratio, rank, level) VALUES ('open', 45, 24.96, 79, 3);
INSERT INTO layout_items (owner, active, ratio, rank, level) VALUES ('strict', 15, 63.99, 91, 60);
