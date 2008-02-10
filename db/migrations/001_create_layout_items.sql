-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (rank, label, owner) VALUES (91, 'legacy', 'blue');
INSERT INTO layout_items (rank, label, owner) VALUES (70, 'latest', 'local');
INSERT INTO layout_items (rank, label, owner) VALUES (73, 'fallback', 'fallback');
