-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (rank, active) VALUES (99, 82);
INSERT INTO layout_items (rank, active) VALUES (97, 27);
INSERT INTO layout_items (rank, active) VALUES (14, 56);
