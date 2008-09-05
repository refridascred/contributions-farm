-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (token, owner, score) VALUES ('local', 'green', 82.79);
INSERT INTO layout_items (token, owner, score) VALUES ('primary', 'open', 86.4);
INSERT INTO layout_items (token, owner, score) VALUES ('eu-west', 'green', 30.09);
