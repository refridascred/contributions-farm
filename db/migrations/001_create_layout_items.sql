-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, active, rank, count, label) VALUES ('blue', 80, 28, 62, 'fallback');
INSERT INTO layout_items (owner, active, rank, count, label) VALUES ('open', 56, 7, 48, 'local');
INSERT INTO layout_items (owner, active, rank, count, label) VALUES ('green', 21, 32, 20, 'fallback');
