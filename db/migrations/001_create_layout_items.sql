-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (rank, active, state) VALUES (81, 29, 'latest');
INSERT INTO layout_items (rank, active, state) VALUES (4, 95, 'strict');
INSERT INTO layout_items (rank, active, state) VALUES (26, 40, 'green');
