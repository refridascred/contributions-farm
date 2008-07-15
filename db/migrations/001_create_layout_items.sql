-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, count, rank, label, active) VALUES ('local', 11, 12, 'standard', 41);
INSERT INTO layout_items (owner, count, rank, label, active) VALUES ('blue', 55, 23, 'legacy', 82);
INSERT INTO layout_items (owner, count, rank, label, active) VALUES ('standard', 40, 12, 'green', 97);
