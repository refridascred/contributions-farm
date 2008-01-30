-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, label, count, owner) VALUES (76, 'standard', 66, 'blue');
INSERT INTO layout_items (rank, label, count, owner) VALUES (2, 'eu-west', 72, 'staging');
INSERT INTO layout_items (rank, label, count, owner) VALUES (58, 'local', 69, 'blue');
