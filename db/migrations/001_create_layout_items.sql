-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, label, owner, level) VALUES (88, 'stable', 'standard', 8);
INSERT INTO layout_items (rank, label, owner, level) VALUES (54, 'blue', 'staging', 94);
