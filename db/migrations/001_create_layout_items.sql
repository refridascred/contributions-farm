-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (token, owner, label, ratio) VALUES ('cached', 'standard', 'strict', 67.42);
INSERT INTO layout_items (token, owner, label, ratio) VALUES ('staging', 'edge', 'latest', 79.91);
