-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (label, rank, weight, state) VALUES ('standard', 2, 7.98, 'stable');
INSERT INTO layout_items (label, rank, weight, state) VALUES ('legacy', 15, 11.57, 'open');
