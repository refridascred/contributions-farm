-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, owner, region, rank, score) VALUES (0, 'primary', 'standard', 32, 15.1);
INSERT INTO layout_items (active, owner, region, rank, score) VALUES (61, 'primary', 'standard', 79, 33.66);
