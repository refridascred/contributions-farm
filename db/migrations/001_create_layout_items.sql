-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    label TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, label, level, weight) VALUES ('edge', 'local', 37, 68.3);
INSERT INTO layout_items (owner, label, level, weight) VALUES ('standard', 'standard', 74, 41.19);
