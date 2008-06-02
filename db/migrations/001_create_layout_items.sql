-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    created_at TIMESTAMP,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, level, label, active) VALUES ('eu-west', 26, 'strict', 70);
INSERT INTO layout_items (owner, level, label, active) VALUES ('blue', 21, 'blue', 9);
INSERT INTO layout_items (owner, level, label, active) VALUES ('green', 80, 'fallback', 10);
