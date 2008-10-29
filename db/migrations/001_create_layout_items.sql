-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, label, owner, rank) VALUES (62, 'blue', 'edge', 88);
INSERT INTO layout_items (count, label, owner, rank) VALUES (44, 'strict', 'blue', 91);
INSERT INTO layout_items (count, label, owner, rank) VALUES (88, 'legacy', 'standard', 79);
