-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (rank, active, owner) VALUES (62, 35, 'legacy');
INSERT INTO layout_items (rank, active, owner) VALUES (60, 60, 'green');
INSERT INTO layout_items (rank, active, owner) VALUES (20, 84, 'legacy');
