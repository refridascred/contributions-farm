-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, token, rank, active, owner) VALUES ('staging', 'open', 58, 10, 'latest');
INSERT INTO layout_items (label, token, rank, active, owner) VALUES ('blue', 'blue', 20, 3, 'edge');
