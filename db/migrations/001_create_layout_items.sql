-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, active, label, rank, owner) VALUES (0, 13, 'primary', 61, 'blue');
INSERT INTO layout_items (level, active, label, rank, owner) VALUES (95, 80, 'standard', 27, 'staging');
INSERT INTO layout_items (level, active, label, rank, owner) VALUES (84, 6, 'primary', 42, 'edge');
