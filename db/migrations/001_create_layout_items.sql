-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (owner, active, score) VALUES ('green', 56, 15.15);
INSERT INTO layout_items (owner, active, score) VALUES ('open', 33, 20.27);
INSERT INTO layout_items (owner, active, score) VALUES ('staging', 92, 82.69);
