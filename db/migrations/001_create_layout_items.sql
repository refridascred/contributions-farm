-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, owner, label, active, rank) VALUES (90.19, 'legacy', 'fallback', 90, 42);
INSERT INTO layout_items (weight, owner, label, active, rank) VALUES (94.7, 'primary', 'edge', 73, 28);
INSERT INTO layout_items (weight, owner, label, active, rank) VALUES (86.94, 'staging', 'green', 89, 19);
