-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (ratio, owner, active) VALUES (19.69, 'staging', 49);
INSERT INTO layout_items (ratio, owner, active) VALUES (26.24, 'legacy', 42);
INSERT INTO layout_items (ratio, owner, active) VALUES (78.68, 'stable', 13);
