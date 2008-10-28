-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (owner, active, score) VALUES ('staging', 69, 98.52);
INSERT INTO layout_items (owner, active, score) VALUES ('green', 30, 66.07);
INSERT INTO layout_items (owner, active, score) VALUES ('edge', 93, 1.09);
