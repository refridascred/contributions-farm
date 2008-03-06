-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (count, rank) VALUES (75, 5);
INSERT INTO layout_items (count, rank) VALUES (63, 65);
INSERT INTO layout_items (count, rank) VALUES (40, 15);
