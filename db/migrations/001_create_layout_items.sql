-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, label, count) VALUES (76, 'green', 78);
INSERT INTO layout_items (rank, label, count) VALUES (71, 'eu-west', 64);
INSERT INTO layout_items (rank, label, count) VALUES (75, 'standard', 6);
